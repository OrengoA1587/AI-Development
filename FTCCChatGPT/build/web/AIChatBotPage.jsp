<%-- 
    Document   : AIChatBotPage
    Created on : Aug 26, 2023, 2:49:47 PM
    Author     : oreng
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
      
    <title> </title>
    <link rel="stylesheet" href="css/DashboardStylesheet.css" />
    
    <link rel="stylesheet" href="css/MainLayout.css" type="text/css"/>

    <link href="css/button-style.css" rel="stylesheet" />
    <link href="css/navbar.css" rel="stylesheet" />
    <link rel="stylesheet" href="bootstrap2/bootstrap.min.css">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;500;600&display=swap" rel="stylesheet">  
    <link href="css/site.css" rel="stylesheet" />
     
    <script src="bootstrap/js/jquery.min.js"></script>
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="bootstrap/js/bs-init.js"></script>
   
    <script src="bootstrap/js/theme.js"></script>
    <script src="bootstrap/js/chart.min.js"></script>
    
    
    <img class ="image-AI-Chat" src="Images/AI_Face_Background.png" alt="Pic" />  
     
</head> 
 <div class="nav" id="nav">             
            <h1 class=" heading-main"><img src="Images/fayettevilletech_logo_full.png" alt="Pic" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AI CHATBOT</h1>
             <ul class="nav-menu clearfix unstyled">
                <li>
                    <a href="" class="three-d">
                        Home
                        <span class="three-d-box"><span class="front">Home</span><span class="back">Go</span></span>
                    </a>
                </li>
                <li>
                    <a href="https://www.faytechcc.edu/" class="three-d">
                        FTCC
                        <span class="three-d-box"><span class="front">FTCC</span><span class="back">Go</span></span>
                    </a>
                </li>
                <li>
                    <a href="https://faytechcc.blackboard.com/?new_loc=%2Fultra%2Fcourse" class="three-d">
                        Blackboard
                        <span class="three-d-box"><span class="front">Blackboard</span><span class="back">Go</span></span>
                    </a>
                </li>
                <li>
                    <a href="https://selfserv.faytechcc.edu/" class="three-d">
                        Self-Service
                        <span class="three-d-box"><span class="front">Self-Service</span><span class="back">Go</span></span>
                    </a>
                </li>
                <li>
                    <a href="https://www.faytechcc.edu/contact/" class="three-d">
                        Contact
                        <span class="three-d-box"><span class="front">Contact</span><span class="back">Go</span></span>
                    </a>
                </li>
                <li>
                    <a href="#" class="three-d">
                        Discover
                        <span class="three-d-box"><span class="front">Discover</span><span class="back">Discover</span></span>
                    </a>
                    <ul class="clearfix unstyled drop-menu">
                        <li>
                            <a href="LoginModal" class="three-d">
                                Login
                                <span class="three-d-box"><span class="front">Login</span><span class="back">Go</span></span>
                            </a>
                        </li>
                        <li>
                            <a href="https://www.faytechcc.edu/news/" class="three-d">
                                News
                                <span class="three-d-box"><span class="front">News</span><span class="back">Go</span></span>
                            </a>
                        </li>
                        <li>
                            <a href="https://www.faytechcc.edu/financial-aid/" class="three-d">
                                Financial Aid
                                <span class="three-d-box"><span class="front">Financial Aid</span><span class="back">Go</span></span>
                            </a>
                        </li>
                        <li>
                            <a href="https://www.faytechcc.edu/events/" class="three-d">
                                Events
                                <span class="three-d-box"><span class="front">Events</span><span class="back">Go</span></span>
                            </a>
                        </li>
                        <li>
                            <a href="https://map.faytechcc.edu/?id=2037#!ct/64989,64988,64235,63975,63968,64237,64238,64239,64240,64241,64242,64243,64244,64245,64221,64227,64229,64230,64231,64232,66570,66571?s/" class="three-d">
                                Map
                                <span class="three-d-box"><span class="front">Map</span><span class="back">Go</span></span>
                            </a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href="index.html" class="three-d">
                        Logout
                        <span class="three-d-box"><span class="front">Logout</span><span class="back">Go</span></span>
                    </a>
                </li>                 
            </ul>
        </div>        
    

 
 
      
    <div class="chatbox-background"  >
        <div  >
            <input class="input-textbox" placeholder="Enter Message --> ">
        </div>
        <br>
        <div>
            <input class="input-textbox textbox-temp" placeholder="Temp">
        </div>        
        <p class="chatbot-output-box" style="text-align:justify;display:inline-block;">     
            <img src="Images/FTCC_AI_Head.png" alt="FTCC Trojan Logo">
        </p>
        <button class="glow-on-hover" onclick="GenerateMessage">Ask ChatAI</button>
        <button class="glow-on-hover" onclick="ClearBox">CLEAR</button>
        <button class="glow-on-hover" onclick="ChangeBackgroundColor">Toggle Blk/Wht</button>
        <button class="glow-on-hover" onclick="ChangeBackgroundColorRandom">RANDOM COLOR</button>
  
      

     


</div>
 
   
 
</html>
