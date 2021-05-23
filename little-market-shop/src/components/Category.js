import React from 'react'
import Cards from './fragments/Cards';
import './Category.css';
import { Grid } from '@material-ui/core';


export const Category=()=> {
    return (
        <>
            <Grid container>
                <Grid item lg={3} md={4} sm={6} xs={12}>
                   <Cards/>
                </Grid>
            </Grid>
        </>
    )
}

export default Category
