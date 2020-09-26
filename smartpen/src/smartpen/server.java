package smartpen;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.Date;
import java.text.SimpleDateFormat;
import java.sql.*;

public class server {
	private ServerSocket ss = null;
	private Socket s = null;
	private static SimpleDateFormat date = new SimpleDateFormat ("yy.MM.dd.HH");
	private static SimpleDateFormat time = new SimpleDateFormat ("mm.ss.SSS");
	private static Date currentTime = new Date ( ); 
	private static String dDate = date.format ( currentTime );
	private static String dTime = time.format ( currentTime );
	private String driver = "com.mysql.cj.jdbc.Driver";
	private String url = "jdbc:mysql://localhost/smat";
	private static Connection con = null;
	private static Statement stmt = null;
	
	
	ArrayList <ChatThread> chatlist = new ArrayList <ChatThread>();
	

	/****서버 부팅****/
	public void start(){
		try {
			ss = new ServerSocket(8888);
			System.out.println("server start");
			connect();
			while(true){
				s = ss.accept();
				ChatThread chat = new ChatThread();
				chatlist.add(chat);
				chat.start();
			}
		} catch (IOException e) {
			System.out.println("[SERVER]start()Exception 발생!!");
		}
	}
	
	/****DB연결****/
	public void connect(){
		try{
			Class.forName(driver);
			con = DriverManager.getConnection(url,"master","java");
			stmt = con.createStatement();
			System.out.println("데이터베이스 연결 성공!");
		}
		catch(Exception e){
			System.out.println("데이터베이스 연결 실패!");
		}
	}
	
	/****DB연결해제****/
	public static void disconnect(){
		try{
			if(stmt!=null)stmt.close();
			if(con!=null)con.close();
			System.out.println("데이터베이스 연결 해제 성공!");
		}
		catch(Exception e){
			System.out.println(e.getMessage());
		}
	}
	
	
	/****삽입SQL****/
	public void insert(String date,String x,String y,String time){
		String sql = "Insert Into data (date,x,y,time) Values";
		try{
		sql += "('"+date+"','"+x+"','"+y+"','"+time+"')";
		System.out.println(sql);
		stmt.executeUpdate(sql);
		}
		catch(Exception e){
			System.out.println("데이터베이스 값 추가 실패!");
		}
	}
	/****삽입SQL****/
	public void insert(String date){
		String sql = "INSERT INTO date(date) SELECT ";
		try{
		sql += "'"+date+"' FROM DUAL WHERE NOT EXISTS(SELECT date FROM date WHERE date = '"+date+"')";
		System.out.println(sql);
		stmt.executeUpdate(sql);
		}
		catch(Exception e){
			System.out.println("데이터베이스 값 추가 실패!");
		}
	}
	
	public BufferedReader bufferreader(){
		BufferedReader in  = new BufferedReader(new InputStreamReader(System.in));
		return in;
	}
	
	
	public static void timeset() {
		currentTime = new Date ( );
		dDate = date.format ( currentTime );
		dTime = time.format ( currentTime );
	}
		
		
	
	/****스레드 동작****/
	class ChatThread extends Thread{
		String msg;
		String[] rmsg;
		
		private BufferedReader inMsg = null;
		
		/****오버라이딩****/
		public ChatThread() {
			
		}
		/****동작****/
		public void run(){
			boolean status = true;
			String cmsg = "";
			System.out.println("##Chat Thread start...");
			try {
				inMsg = new BufferedReader(new InputStreamReader(s.getInputStream()));
				
				/****명령****/
				while(status){
					msg = inMsg.readLine();
					rmsg = msg.split("/");
					if(rmsg[1].equals("logout")){
						chatlist.remove(this);
						status = false;
					}
					else if(msg != null) {
						if ((!rmsg[0].equals("0"))&&(!rmsg[1].equals("0"))&&(!rmsg[1].equals("0"))) {
							if(!cmsg.equals(msg)) {
								timeset();
								insert(dDate,rmsg[0],rmsg[1],dTime);
								insert(dDate);
								cmsg = msg;
							}
						}
					}
				}
				this.interrupt();
				System.out.println("##"+this.getName()+"stop!!");
			} catch (IOException e) {
				chatlist.remove(this);
				e.printStackTrace();
				System.out.println("[Thread]run() IOException 발생!!");
			}
		}
	}

	
	/****메인****/
	public static void main(String[] args){
		server server = new server();
		server.start();
		Runtime.getRuntime().addShutdownHook(new Thread() {
            public void run() {
            	disconnect();//서버 종료시 DB연결해제
            }
		});
	}
}
