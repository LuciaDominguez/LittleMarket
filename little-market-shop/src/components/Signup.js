import React from 'react'
import {Button, FormControl, Grid, IconButton, Input, InputAdornment, InputLabel, makeStyles} from '@material-ui/core';
import { Email, Person, Phone, Visibility, VisibilityOff } from '@material-ui/icons';
import clsx from "clsx";
import profile from './resource/profile.png';
import './Signup.css';

const useStyles= makeStyles((theme)=>({
    root: {
        display:"flex",
        flex: "wrap",
        }, 
        margin: {
         margin: theme.spacing(1)
        },
        textField:{
            width: 300
        },
        button:{
            margin: theme.spacing(2)
        },
}));

export const Signup= ()=> {

    const classes = useStyles();
    const [values,setValues]= React.useState({
        password:"",
        showPassword: false
    });
    const handleChange=(prop)=>(event)=>{
        setValues({...values,[prop]:event.target.value});
    }
    const handleShowPassword=()=>{
        setValues({...values, showPassword: !values.showPassword})
    };

    return (
        <>
            <div>
                <Grid container alignItems="center" direction="column" justify="center">
                    <div className="header">Registro</div>
                    <img src={profile} alt="profile" className="img-signup"></img>
                </Grid>
                <form className={classes.root}>
                    <Grid container alignItems="center" direction="column" justify="center">
                        <Grid item xs={12}>
                            <FormControl className={clsx(classes.margin, classes.textField)}>
                                <InputLabel htmlFor="input-with-icon-adornment">Nombre</InputLabel>
                                <Input id="nombre"
                                startAdornment={
                                    <InputAdornment position="start">
                                        <Person/>
                                    </InputAdornment>
                                }placeholder="Nombre"></Input>
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <FormControl className={clsx(classes.margin, classes.textField)}>
                                <InputLabel htmlFor="input-with-icon-adornment">Apellido Paterno</InputLabel>
                                <Input id="apellidoPaterno"
                                startAdornment={
                                    <InputAdornment position="start">
                                        <Person/>
                                    </InputAdornment>
                                }placeholder="Apellido paterno"></Input>
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <FormControl className={clsx(classes.margin, classes.textField)}>
                                <InputLabel htmlFor="input-with-icon-adornment">Apellido Materno</InputLabel>
                                <Input id="apellidoMaterno"
                                startAdornment={
                                    <InputAdornment position="start">
                                        <Person/>
                                    </InputAdornment>
                                }placeholder="Apellido materno"></Input>
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <FormControl className={clsx(classes.margin, classes.textField)}>
                                <InputLabel htmlFor="input-with-icon-adornment">Correo electronico</InputLabel>
                                <Input id="correo"
                                startAdornment={
                                    <InputAdornment position="start">
                                        <Email/>
                                    </InputAdornment>
                                }placeholder="Correo electronico"></Input>
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <FormControl className={clsx(classes.margin, classes.textField)}>
                                <InputLabel htmlFor="input-with-icon-adornment">Contraseña</InputLabel>
                                <Input id="contraseña"
                                type={values.showPassword?"text":"password"}
                                value={values.password}
                                onChange={handleChange("password")}
                                endAdornment={
                                    <InputAdornment position="end">
                                        <IconButton
                                            aria-label="toggle password visibility"
                                            onClick={handleShowPassword}
                                            >
                                            {values.showPassword? <Visibility/>: <VisibilityOff/>}
                                        </IconButton>
                                    </InputAdornment>
                                }>
                                </Input>
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <FormControl className={clsx(classes.margin, classes.textField)}>
                                <InputLabel htmlFor="input-with-icon-adornment">Número telefonico</InputLabel>
                                <Input id="telefono"
                                startAdornment={
                                    <InputAdornment position="start">
                                        <Phone/>
                                    </InputAdornment>
                                }placeholder="Número telefonico"></Input>
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <Button type="submit" variant="contained" className={classes.button} >Registrar</Button>
                        </Grid>
                    </Grid>
                </form>
            </div>
        </>
    )
}

export default Signup
