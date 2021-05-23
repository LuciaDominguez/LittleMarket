import { Grid, Paper, FormControl, Input, InputAdornment, Button, makeStyles } from '@material-ui/core';
import { Person } from '@material-ui/icons';
import React from 'react';
import './Commentary.css';
import Comment from './Comment.js'

const useStyles = makeStyles((theme)=>({
    contenpaper:{
        margin: `${theme.spacing(1)}px auto`,
        maxWidth:900,
        padding: theme.spacing(2),
    },
}));

export const Commentary=() =>{
    const classes = useStyles();
    return (
        <>
            <Grid container direction="column">
              <Grid item xs>
                <Paper className={classes.contenpaper}>
                <h1>Comentarios</h1>
                <form>
                       <FormControl className="commentary">
                            <Input id="box-comentario"
                            startAdornment={
                                <InputAdornment position="start">
                                    <Person/>
                                </InputAdornment>
                            }>
                         </Input>
                        </FormControl>
                        <Button>Comentar</Button>
                </form>
                <div id="comentarios">
                    <Comment/>
                    <Comment/>
                    <Comment/>
                </div>
                </Paper>
              </Grid>
            </Grid>
        </>
    )
}

export default Commentary
