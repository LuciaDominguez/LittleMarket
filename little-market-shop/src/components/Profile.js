import { Button, FormControl, InputLabel,Input, makeStyles, InputAdornment, IconButton } from '@material-ui/core';
import { Email, Person, Visibility, VisibilityOff } from '@material-ui/icons';
import clsx from "clsx";
import React from 'react';
import './Profile.css';

const useStyles= makeStyles((theme)=>({
    root:{
        display:"flex",
        flex:"wrap"
    },
    margin: {
        margin:theme.spacing(1)
    },
    textField:{
        minWidth:300,
        maxWidth:600
    },
    button:{
        margin: theme.spacing(2)
    }
}));
  
export const Profile=()=> {
    const classes = useStyles();
    const [values,setValues]= React.useState({
        password:"",
        showPassword: false,
        read:true
    });
    const handleChange=(prop)=>(event)=>{
        setValues({...values,[prop]:event.target.value});
    }
    const handleShowPassword=()=>{
        setValues({...values, showPassword: !values.showPassword})
    };
    const handleReadToWrite=()=>{
        setValues({...values, read: !values.read})
    };
    const saveRead=()=>{
        setValues({...values, read: true})
    };

    return (
        <>
            <div className="container">
                <h1 className="header">Mi cuenta</h1>
                    <form>
                    <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Nombre</InputLabel>
                            <Input id="profile-nombre"
                            inputProps={{readOnly:values.read}}
                            startAdornment={
                                <InputAdornment position="start">
                                    <Person/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Apellido Paterno</InputLabel>
                            <Input id="profile-paterno"
                            inputProps={{readOnly:values.read}}
                            startAdornment={
                                <InputAdornment position="start">
                                    <Person/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Apellido Materno</InputLabel>
                            <Input id="profile-materno"
                            inputProps={{readOnly:values.read}}
                            startAdornment={
                                <InputAdornment position="start">
                                    <Person/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Correo Electronico</InputLabel>
                            <Input id="profile-email"
                            inputProps={{readOnly:values.read}}
                            startAdornment={
                                <InputAdornment position="start">
                                    <Email/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Contraseña</InputLabel>
                            <Input id="profile-contraseña"    
                            type={values.showPassword?"text":"password"} 
                            value={values.password}
                            onChange={handleChange("password")}
                            inputProps={{readOnly:values.read}}
                            endAdornment={
                                <InputAdornment position="end">
                                    <IconButton
                                    aria-label="toggle password visibility"
                                    onClick={handleShowPassword}
                                    >
                                    {values.showPassword?<Visibility/>:<VisibilityOff/>}
                                    </IconButton>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Número Telefonico</InputLabel>
                            <Input id="profile-telefono"
                            inputProps={{readOnly:values.read}}
                            startAdornment={
                                <InputAdornment position="start">
                                    <Person/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <Button variant="contained" className={classes.button} onClick={saveRead}>Guardar cambios</Button>
                        </div>
                    </form>
                    <div className="buttons">
                        <Button variant="contained" onClick={handleReadToWrite}>Editar cuenta</Button>
                    </div>
                    <div className="buttons">
                        <Button variant="contained">Eliminar cuenta</Button>
                    </div>
                    <Button variant="contained">Cerrar Sesion</Button>
            </div>
        </>
    )
}

export default Profile
