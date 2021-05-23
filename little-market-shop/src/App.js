import React from 'react';
import './App.css'
import {BrowserRouter as Router, Route, Switch} from "react-router-dom";
import Index from './components/Index';
import Login from './components/Login';
import Signup from './components/Signup';
import Navbar from './components/Navbar';
import Profile from './components/Profile';
import ShoppingCart from './components/Shoppingcart';
import MyShopping from './components/MyShopping';
import Category from './components/Category';
import Product from './components/Product';
import Admin from './components/Admin';



function App() {
  return ( 
      <Router>
        <Navbar/>
        <Switch>
        <Route exact path="/" component={Index}></Route>
        <Route exact path="/index" component={Index}></Route>
        <Route exact path="/login" component={Login}></Route>
        <Route exact path="/signup" component={Signup}></Route>
        <Route exact path="/profile/:id_usuario" component={Profile}></Route>
        <Route exact path="/shoppingcart/:id_usuario" component={ShoppingCart}></Route>
        <Route exact path="/myshopping/:id_usuario" component={MyShopping}></Route>
        <Route exact path="/category/:categoria" component={Category}></Route>
        <Route exact path="/product/:id_producto" component={Product}></Route>
        <Route exact path="/admin" component={Admin}></Route>
        </Switch>
      </Router>
  );
}

export default App;
