import { Button, FormControl, IconButton, Input, InputAdornment, InputLabel, makeStyles, Grid} from '@material-ui/core';
import { Email, VisibilityOff,Visibility} from '@material-ui/icons';
import user from './resource/user.png';
import clsx from "clsx";
import React from 'react';
import './Login.css';
import { Link } from 'react-router-dom';

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

export const Login = () =>{
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
                <div className="header">Inicia Sesión</div>
                <img src={user} alt="Login-logo" className="img-login"/>
                
            </Grid>
            <form className={classes.root}>
                <Grid container alignItems="center" direction="column" justify="center">
                <Grid item xs={12}>
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Correo electronico</InputLabel>
                            <Input id="correo-inicio"
                            startAdornment={
                                <InputAdornment position="start">
                                    <Email/>
                                </InputAdornment>
                            }
                            placeholder="Ingrese su correo registrado"></Input>
                        </FormControl>
                    </Grid>
                    <Grid item xs={12}>
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Contraseña</InputLabel>
                            <Input id="contraseña-inicio"
                            type={values.showPassword?"text":"password"}
                            value={values.password}
                            onChange={handleChange("password")}
                            endAdornment={
                                <InputAdornment position="end">
                                    <IconButton
                                        aria-label="toggle password visibility"
                                        onClick={handleShowPassword}
                                    >
                                        {values.showPassword ? <Visibility /> : <VisibilityOff />}
                                    </IconButton>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                    </Grid>
                    <Grid item xs={12}>
                        <Button type="submit" variant="contained" className={classes.button}>Iniciar sesión</Button>
                    </Grid>
                </Grid>
            </form>
            <Grid container alignItems="center" direction="column" justify="center">
                <Grid item xs={12}>
                    <Link to="/signup">¿No tienes cuenta? Registrate</Link>
                </Grid>
                <Grid item xs={12}>
                    <a href="https://www.vecteezy.com/free-vector/blue">Blue Vectors by Vecteezy</a>
                </Grid>
            </Grid>
         </div>
         
        </>
    )
}

export default Login
