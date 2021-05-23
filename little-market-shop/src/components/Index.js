import { Grid } from '@material-ui/core';
import React from "react";
import Cards from './fragments/Cards';
import './Index.css';
import bienvenido from './resource/bienvenido.jpg';
export const Index= (props)=>{
    return(
        <>
        <div className=".index">
            <div >
                <img src={bienvenido} alt="bienvenido" className="banner"></img>
            </div>
            <div>
                <h1 className="titulo">Reciente</h1>
                <Grid container direction="row">
                <Grid item lg={3} md={4} sm={6} xs={12}>
                   <Cards/>
                </Grid>
                </Grid>
            </div>
            <div>
                <h1 className="titulo">Categoria 1</h1>
                <Grid container direction="row">
                <Grid item lg={3} md={4} sm={6} xs={12}>
                   <Cards/>
                </Grid>
                </Grid>
            </div>
        </div>
        </>
    )
}

export default Index;