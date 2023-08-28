<%-- 
    Document   : LoginAction
    Created on : Aug 26, 2023, 6:17:29 AM
    Author     : oreng
--%>
<%@page import="javax.swing.JOptionPane"%>
<%@page import="java.io.InputStream"%>
<%@page import="java.io.FileInputStream"%>
<%@page import="java.util.Properties"%>
<%@ page  import="java.sql.*" %>
<%@ page import="java.util.List" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%
    //ReadSQL sqlRead = new ReadSQL();
    String username = request.getParameter("username");
    String password = request.getParameter("password");
     
                    
    if(username == null || password == null)
        {
            response.sendRedirect("error.jsp");
        }

    else
{
   // hash.setHashText(password); @page import ="HashEncryption.HashSHA512Encryption"
    //password = hash.getHashText( );
    //Make changes to the connection string(database name, user/password)
    //Make changes to the String query(change table name)
    Properties props = new Properties();
    try {
        //(InputStream input = "C:\\Users\\oreng\\OneDrive\\Documents\\NetBeansProjects\\FTCCChatGPT\\src\\config\\config.properties" {
        FileInputStream input = new FileInputStream("C:\\Users\\oreng\\OneDrive\\Documents\\GitHub\\AI Development\\FTCCChatGPT\\src\\java\\config\\config.properties");
        props.load(input);//All Files	C:\Users\oreng\OneDrive\Documents\GitHub\AI Development\FTCCChatGPT\src\config\config.properties
        input.close(); 

        String driver = props.getProperty("com.mysql.jdbc.Driver");
        if (driver != null) {
            Class.forName(driver) ;
        }

        String url = props.getProperty("jdbc.url");
        String jdbcName = props.getProperty("jdbc.username");
        String password1 = props.getProperty("jdbc.password");
        Connection con = DriverManager.getConnection(url, jdbcName, password1);
         
          
      

        String query = "select * From Student where Username=? AND Password=?";
        PreparedStatement ps = con.prepareStatement(query);
        ps.setString(1,username );
        ps.setString(2,password );    
        ResultSet rs = ps.executeQuery();    
         
                 
        if (rs.next()){
        
            session.setAttribute("UserID", username);
            response.sendRedirect("LoginTest.html");              
        }
        
        else{
            
         }
        ps.close();
        rs.close();
        con.close();
    }catch(Exception e)
    {     
        out.println(e); 
    } 
}
//Connection con = DriverManager.getConnection("jdbc:mysql://sql9.freemysqlhosting.net/sql9641368","sql9641368","8fe6iEVZLB");
        //Class.forName("com.mysql.jdbc.Driver");
       //Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/mysql", "root", "Ant2014##");
       // sqlRead.ReadSQL();
        //Connection con = sqlRead.getConnections();




















%>