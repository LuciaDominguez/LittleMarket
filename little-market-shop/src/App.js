import React from 'react';
import {BrowserRouter as Router, Route} from "react-router-dom";
import Index from './components/Index';
import Login from './components/Login';
import Signup from './components/Signup';



function App() {
  return ( 
      <Router>
         
        <Route exact path="/" component={Index}></Route>
        <Route exact path="/index" component={Index}></Route>
        <Route exact path="/login" component={Login}></Route>
        <Route exact path="/signup" component={Signup}></Route>
      </Router>
  );
}

export default App;
