* {
  box-sizing: border-box;
}

html {
	height: 100%;

}

body {
  font-family: 'Roboto', 'Oxygen',
    'Ubuntu', 'Cantarell', 'Fira Sans', 'Droid Sans', 'Helvetica Neue', Arial, Helvetica,
    sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
	background-color: silver;
	height: 100%;
	margin: 0;
}

span {
	padding-right: 15px;
	padding-left: 15px;
}

.container {
	display: flex;
  justify-content: center;
	align-items: center;
	width: 100%;
	height: 100%;
}

.chat {
	height: 300px;
	width: 50vw;
	display: flex;
	flex-direction: column;
  justify-content: center;
	align-items: center;
} 

::-webkit-input-placeholder { 
	color: .711 
}
 
input { 
	border: 0; 
	padding: 15px; 
	margin-left: auto;
	border-radius: 10px; 
}

.messages {
	display: flex;
	flex-direction: column;
	overflow: scroll;
	height: 90%;
	width: 100%;
	background-color: white;
	padding: 15px;
	margin: 15px;
	border-radius: 10px;
}

#bot {
	margin-right: auto;
}

#user {
	margin-left: auto;
}


.bot {
	font-family: Consolas, 'Courier New', Menlo, source-code-pro, Monaco,  
	monospace;
}

.avatar {
	height: 25px;
}

.response {
	display: flex;
	align-items: center;
	margin: 1%;
}


/* Mobile */

@media only screen and (max-width: 980px) {
  .container {
		flex-direction: column; 
		justify-content: flex-start;
	}
	.chat {
		width: 75vw;
		margin: 10vw;
	}
}