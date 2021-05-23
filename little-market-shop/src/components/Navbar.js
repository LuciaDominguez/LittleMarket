
import { Breadcrumbs, IconButton } from '@material-ui/core';
import { Close, Menu } from '@material-ui/icons';
import React from 'react';
import { NavLink } from 'react-router-dom';
import './Navbar.css';
import logo from './resource/logo.png';
import Categories from './Categories';


export const Navbar = () => {
    const [values,setValues]= React.useState({
        click:false
    });

    const handleClick = ()=>{
        setValues({...values, click: !values.click})
    }

    return (
        <>
            <nav className='navbar'>
                <div className='nav-container'>
                    <NavLink exact to="/" activeClassName="active" className="nav-logo">
                        <img src={logo} alt="logo" className="logo"></img>
                    </NavLink>
                    <Breadcrumbs aria-label="breadcrumb" className={values.click ? "nav-menu active": "nav-menu"}>
                        <div className="nav-item"  >
                            <NavLink exact to="/login" activeClassName="active" className="nav-links">
                                Iniciar Sesión
                            </NavLink>
                        </div>
                        <div className="nav-item">
                            <NavLink exact to="/signup" activeClassName="active" className="nav-links">
                                Registrate
                            </NavLink>
                        </div>
                        <div className="nav-item">
                            <NavLink exact to="/shoppingcart/:id_usuario" activeClassName="active" className="nav-links">
                            Carrito 
                            </NavLink>
                        </div>
                        <div className="nav-item">
                            <NavLink exact to="/myshopping/:id_usuario" activeClassName="active" className="nav-links">
                                Mis compras 
                            </NavLink>
                        </div>
                    </Breadcrumbs>
                    <div className="nav-icon" onClick={handleClick}>
                        <IconButton onClick={handleClick}>
                            {values.click ? <Close style={{ color: '#32f444' }}/> : <Menu style={{ color: '#32f444' }}/>}
                        </IconButton>
                    </div>
                </div>
            </nav>
            <Categories/>
        </>
    )
}

export default Navbar
