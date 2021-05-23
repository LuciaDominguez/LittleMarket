import React from 'react';
import {makeStyles, Paper,Grid, Button} from '@material-ui/core';
import profile from './../resource/profile.png';
import './ProductCards.css';
import { AttachMoney, ShoppingCart, ThumbUp } from '@material-ui/icons';

const useStyles = makeStyles((theme)=>({
    headerpaper:{
        maxWidth:900,
        minWidth:100,
        margin: `${theme.spacing(1)}px auto`,
        padding: theme.spacing(2),

    },
    contenpaper:{
        margin: `${theme.spacing(1)}px auto`,
        maxWidth:900,
        padding: theme.spacing(2),
    },
    buttonA:{
        margin: theme.spacing(1),
        width:200
    },
    textField:{
        width:600
    },
}));

export const ProductCards=()=> {
    const classes = useStyles();

    return (
        <>
            <div>
                <Grid container direction="column">
                    <Grid item xs>
                      <Paper className={classes.headerpaper}>
                        <Grid container wrap="nowrap" spacing={2}>
                            <Grid item xs>
                            <h1 id="nombre">Nombre del producto</h1>
                            </Grid>
                         </Grid>
                       </Paper>
                    </Grid>
                        <Grid item xs>
                            <Paper className={classes.contenpaper}>
                                <Grid container wrap="nowrap" spacing={1} direction="column">
                                    <Grid item xs>
                                      <div className="order-media">
                                         <img alt="complex" src={profile} className="marco"/>
                                      </div>
                                      <div className="order-media">
                                         <video alt="complex" className="marco-video" controls>
                                             <source src="" type="video/mp4"></source>
                                         </video>
                                      </div>
                                    </Grid>
                                   <Grid item xs>
                                     <div className="information">
                                     <h1 id="producto">Nombre del producto</h1>
                                     <h1 id="precio"><AttachMoney/>10.00</h1>
                                     <h2>Descripción</h2>
                                     <div className="limit"><p id="descripcion">Una descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del productoUna descripcion del producto</p></div>
                                     </div>
                                   </Grid>
                                  <Grid item>
                                     <div className="information">
                                     <Button style={{background:"#32f444"}} variant="contained" startIcon={<ShoppingCart/>} className={classes.buttonA}>Comprar</Button>
                                      <Button style={{background:"#32f444"}} variant="contained" startIcon={<ThumbUp/>} className={classes.buttonA}>Me gusta</Button>
                                      <div className="likes"><h3>Le gusta a: <label id="like">64</label><label> personas</label></h3></div>
                                     </div>                                   
                                  </Grid>
                                </Grid>
                            </Paper>
                        </Grid> 
                        <Grid item xs>
 
                        </Grid>                            
                </Grid>
            </div>
        </>
    )
}

export default ProductCards
