package smartpen;

import java.awt.CardLayout;
import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.awt.event.ActionEvent;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JTextArea;
import javax.swing.JScrollPane;

import gnu.io.CommPort;
import gnu.io.CommPortIdentifier;
import gnu.io.SerialPort;

//import java.io.FileDescriptor;
//import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

public class client implements ActionListener, Runnable{
	static int anglex = 287;
	static int round = 115000;
	static double setbo = 2.4;
	/****GUI선언****/
	JFrame frame,errorFrame;
	JPanel loginPanel,logoutPanel,errorPanel;
	Container container;
	CardLayout cardlayout;
	JButton loginButton,BlueConButton,logoutButton,settingButton,errorok= new JButton("확인");
	JLabel userLabel,bluestateLabel,error;
	static JTextArea outputTextArea1,outputTextArea2;
	JScrollPane scrollpane1,scrollpane2;
	
	/****서버 연걸 관련선언****/
	private Socket socket;
	private BufferedReader inMsg = null;
	private static PrintWriter outMsg = null;
	private String ip;
	private Thread thread,sendthread;

	
	/****상태****/
	static boolean status,areastatus;
	
	/****위치****/
	static int x,y,z,gx,gy,gz = 0;
	static int x1,y1,z1,gx1,gy1,gz1;
	static int i = 0;
	
	
	/****클라이언트 실행시****/
	client(String ip){
		this.ip = ip;
		frame = new JFrame("SmartPenConnecter");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		container = new JPanel();
		cardlayout = new CardLayout();
		container.setLayout(cardlayout);
		makeLoginPanel();
		makeLogoutPanel();
		addActionListener(this);
		frame.add(container);
		frame.setSize(400, 360);
		frame.setResizable(false);
		frame.setVisible(true);
	}
	
	
	
	/****로그인 판넬 만들기****/
	void makeLoginPanel(){
		loginPanel = new JPanel();
		loginPanel.setLayout(null);
		loginPanel.setBackground(new Color(53,183,238));
		userLabel = new JLabel("블루투스 : ");
		bluestateLabel = new JLabel("연결실패");
		loginButton = new JButton("로그인");
		BlueConButton = new JButton("블루투스 연결");
		userLabel.setBounds(55, 62, 61, 18);
		bluestateLabel.setBounds(116, 62, 61, 18);
		loginButton.setBounds(243, 237, 73, 28);
		BlueConButton.setBounds(90, 237 , 140, 28);
		loginPanel.add(userLabel);loginPanel.add(bluestateLabel);
		loginPanel.add(loginButton);
		loginPanel.add(BlueConButton);
		container.add(loginPanel, "login");
	}
	
	
	
	/****로그아웃 판넬만들기****/
	void makeLogoutPanel(){
		logoutPanel = new JPanel();
		logoutPanel.setLayout(null);
		logoutPanel.setBackground(new Color(53,183,238));
		outputTextArea1 = new JTextArea("0,0,0,0,0,0,0,0\n0,0,0,0,0,0,0,0\n",10,30);
		outputTextArea2 = new JTextArea("0/0/0\n0/0/0\n",10,30);
		outputTextArea1.setEditable(false);
		outputTextArea2.setEditable(false);
		scrollpane1 = new JScrollPane(outputTextArea1,JScrollPane.VERTICAL_SCROLLBAR_ALWAYS,
				JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
		scrollpane2 = new JScrollPane(outputTextArea2,JScrollPane.VERTICAL_SCROLLBAR_ALWAYS,
				JScrollPane.HORIZONTAL_SCROLLBAR_NEVER);
		logoutButton = new JButton("로그아웃");
		settingButton = new JButton("위치 초기화");
		scrollpane1.setBounds(23, 28, 174, 243);
		scrollpane2.setBounds(197, 28, 174, 243);
		logoutButton.setBounds(154, 286, 86, 28);
		settingButton.setBounds(10, 286, 102, 28);
		logoutPanel.add(scrollpane1);
		logoutPanel.add(scrollpane2);
		logoutPanel.add(logoutButton);
		logoutPanel.add(settingButton);
		container.add(logoutPanel,"logout");
	}
	
	
	
	/****경고창****/
	void error(String err,int nstr,int ntoken){
		int i = (nstr*13)+(ntoken*3);
		errorFrame =  new JFrame("에러");
		errorPanel = new JPanel();
		errorPanel.setLayout(null);
		errorPanel.setBackground(new Color(255,150,0));
		error = new JLabel(err);
		error.setBounds((100-(i/2)), 10, i, 18);
		errorok.setBounds(70, 33, 60, 28);
		errorPanel.add(error);
		errorPanel.add(errorok);
		errorFrame.add(errorPanel);
		errorFrame.setResizable(false);
		errorFrame.setSize(200, 100);
		errorFrame.setVisible(true);
	}
	
	
	
	
	/****액션리스너 등록****/
	void addActionListener(ActionListener acl){
		loginButton.addActionListener(acl);
		BlueConButton.addActionListener(acl);
		logoutButton.addActionListener(acl);
		settingButton.addActionListener(acl);
		errorok.addActionListener(acl);
	}
	
	
	
	/****버튼 동작 구문****/
	@SuppressWarnings("deprecation")
	@Override
	public void actionPerformed(ActionEvent e) {
		Object obj = e.getSource();
		/****로그인 버튼을 눌렀을때****/
		if(obj==loginButton){
			areastatus = true;
			status = true;
			if(bluestateLabel.getText().equals("연결실패")) {
				error("블루투스 연결을 하세요.",10,3);
			}
			else if(connectServer()) {
				cardlayout.show(container, "logout");
			}
			else{
				error("서버가 열려있지 않습니다.",11,3);
			}
		}
		
		/****블루투스연결버튼 눌렀을때****/
		if(obj ==BlueConButton) {
			try {
				connect("COM4");
				bluestateLabel.setText("연결성공");
			} catch (Exception e1) {
				error("블루투스 연결에 실패.",9,3);
			}
		}
		
		
		/****로그아웃 버튼을 눌렀을때****/
		if(obj==logoutButton){
			cardlayout.show(container, "login");
			outputTextArea1.setText("0,0,0,0,0,0,0,0\n0,0,0,0,0,0,0,0\n");
			outputTextArea2.setText("0/0/0\n0/0/0\n");
			outMsg.println("client/"+"logout");
			outMsg.close();
			areastatus = false;
			try{
				inMsg.close();
				socket.close();
				sendthread.stop();
			}
			catch(IOException e1){
				e1.printStackTrace();
			}
			
			status = false;
		}
		
		if(obj == settingButton) {
			setg();
		}
		
		
		/****에러메시지 종료버튼****/
		if(obj==errorok){
			errorFrame.dispose();
		}
	}
	
	
	
	/****서버 연결****/
	public boolean connectServer(){
		try{
			socket = new Socket(ip,8888);
			System.out.println("[Client]Server 연결 성공!!");
			inMsg = new BufferedReader(new InputStreamReader(socket.getInputStream()));
			outMsg = new PrintWriter(socket.getOutputStream(),true);
			thread = new Thread(this);
			thread.start();
			sendthread = (new Thread(new Sendmsg()));
			sendthread.start();
			return true;
		}
		catch(Exception e){
			System.out.println("[Server]start() Exception 발생!!");
			return false;
		}
	}
	
	/****블루투스 연결****/
	void connect ( String portName ) throws Exception
    {
        CommPortIdentifier portIdentifier = CommPortIdentifier.getPortIdentifier(portName);
        if ( portIdentifier.isCurrentlyOwned() )
        {
            System.out.println("Error: Port is currently in use");
        }
        else
        {
            //클래스 이름을 식별자로 사용하여 포트 오픈
            CommPort commPort = portIdentifier.open(this.getClass().getName(),2000);
            
            if ( commPort instanceof SerialPort )
            {
                //포트 설정(통신속도 설정. 기본 9600으로 사용)
                SerialPort serialPort = (SerialPort) commPort;
                serialPort.setSerialPortParams(9600,SerialPort.DATABITS_8,SerialPort.STOPBITS_1,SerialPort.PARITY_NONE);
                
                //Input,OutputStream 버퍼 생성 후 오픈
                InputStream in = serialPort.getInputStream();
                OutputStream out = serialPort.getOutputStream();
                
                 //읽기, 쓰기 쓰레드 작동
                (new Thread(new SerialReader(in))).start();
                (new Thread(new SerialWriter(out))).start();
                

            }
            else
            {
                System.out.println("Error: Only serial ports are handled by this example.");
            }
        }     
    }
	
	
	//데이터 수신
    public static class SerialReader implements Runnable 
    {
        InputStream in;
        String msg;
        
        public SerialReader ( InputStream in )
        {
            this.in = in;
        }
        
        public void run ()
        {
            byte[] buffer = new byte[1024];
            int len = -1;
            try
            {
                while ( ( len = this.in.read(buffer)) > -1 )
                {
                	msg = new String(buffer,0,len);
                	outputTextArea1.append(msg);
                	outputTextArea1.setCaretPosition(outputTextArea1.getDocument().getLength());
                	sumg();
                }
            }
            catch ( IOException e )
            {
                e.printStackTrace();
            }            
        }
    }

    /** */
    //데이터 송신
    public static class SerialWriter implements Runnable 
    {
        OutputStream out;
        
        public SerialWriter ( OutputStream out )
        {
            this.out = out;
        }
        
        public void run ()
        {
            try
            {
                int c = 0;
                while ( ( c = System.in.read()) > -1 )
                {
                    this.out.write(c);
                }                
            }
            catch ( IOException e )
            {
                e.printStackTrace();
            }            
        }
    }
	
    /****쉼표 나누기 나중에 백터변환 들어갈곳****/
    public static String msgsplit(String msg) {
    	String rmsg;
    	String[] smsg;
    	smsg = msg.split(",");
    	if(Integer.parseInt(smsg[1]) == 0) {
    		gy = 0;
    	}
    	if(Integer.parseInt(smsg[2]) == 0) {
    		gx = 0;
    	}
    	if((gy/anglex) > 300) {
    		smsg[1] = Integer.toString((int) (Integer.parseInt(smsg[1]) + (((gy/anglex)-400)*(setbo+0.5))));
    	}
    	else {
    		smsg[1] = Integer.toString((int) (Integer.parseInt(smsg[1]) + (((gy/anglex))*(setbo+0.30))));
    	}
    	if((gx/anglex) > 300) {
    		smsg[2] = Integer.toString((int) (Integer.parseInt(smsg[2]) - (((gx/anglex)-400)*(setbo+0.5))));
    	}
    	else {
    		smsg[2] = Integer.toString((int) (Integer.parseInt(smsg[2]) - (((gx/anglex))*(setbo+0.5))));
    	}
    	if(smsg[0].equals("1")) {
    		rmsg = x/150+"/"+y/150+"/"+z/150+"\n";
    	}
    	else
    		rmsg = "";
    	if(areastatus == true) {
    		x1 =Integer.parseInt(smsg[1]);
    		y1 =Integer.parseInt(smsg[2]);
    		z1 =Integer.parseInt(smsg[3]);
	    	gx1 =Integer.parseInt(smsg[4]);
	    	gy1 =Integer.parseInt(smsg[5]);
	    	gz1 = Integer.parseInt(smsg[6]);
    	}
    	return rmsg;
    }
    
	
    /****텍스트에리어 마지막줄 읽기****/
    public static String linesplit(String msg) {
    	String rmsg;
    	String[] smsg;
    	smsg = msg.split("\n");
    	rmsg = smsg[smsg.length-2];
    	return rmsg;
    }
    
   
    
    /****서버데이터전송****/
    public class Sendmsg implements Runnable {
    	String msg1,msg2,smsg,smsg1 = "";
    	public Sendmsg() {
    	}
		public void run() {
    		while(status) {
    			msg1 = linesplit(outputTextArea1.getText());
				if(!smsg1.equals(msgsplit(msg1))) {
					outputTextArea2.append(msgsplit(msg1));
					outputTextArea2.setCaretPosition(outputTextArea2.getDocument().getLength());
					smsg1 = msgsplit(msg1);
				}
				msg2 = linesplit(outputTextArea2.getText());
				if(msg2 != smsg & msg2 != "\n") {
					outMsg.println(msg2);
					smsg = msg2;
				}
			}
    	}
    	
    }
    
    
    public static void setg() {
    	x=0;
    	y=0;
    	z=0;
    }
    public static void sumg() {
    	if(areastatus == true) {
    		x = x+x1;
    		y = y+y1;
    		z= z+z1;
	    	gx = gx + gx1;
	    	gy = gy +gy1;
	    	gz = gz + gz1;
	    	if(gx > round) {
	    		gx -=round;
	    	}
	    	if(gx < 0) {
	    		gx+=round;
	    	}
	    	if(gy > round) {
	    		gy -=round;
	    	}
	    	if(gy < 0) {
	    		gy+=round;
	    	}
	    	if(gz > round) {
	    		gz -= round;
	    	}
	    	if(gz < 0) {
	    		gz+=round;
	    	}
	    	System.out.println(gx/anglex+"/"+gy/anglex+"/"+gz/anglex);
    		
    	}
    	
    }
	
	/****메인****/
	@SuppressWarnings("unused")
	public static void main(String[] args){
		client cl = new client("220.69.240.198");
	}


	
	/****동작****/
	@Override
	public void run() {
		while(status){

			
		}
		System.out.println("[Client]"+thread.getName()+"종료됨");
		
	}
}