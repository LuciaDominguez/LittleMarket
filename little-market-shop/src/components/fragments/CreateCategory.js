import { AttachMoney, ShoppingBasket} from '@material-ui/icons'
import React from 'react'
import './CreateProduct.css'
import clsx from "clsx";
import { FormControl, InputLabel, Input, InputAdornment, Button, makeStyles } from '@material-ui/core';

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


export const CreateCategory=()=> {
    const classes = useStyles();

    return (
        <>
             <div className="container">
                <h1 className="header">Crear Categoria</h1>
                    <form>
                    <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Categoria</InputLabel>
                            <Input id="categoria-nombre"
                            startAdornment={
                                <InputAdornment position="start">
                                    <ShoppingBasket/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Descripcion</InputLabel>
                            <Input id="categoria-descripcion"
                            startAdornment={
                                <InputAdornment position="start">
                                    <AttachMoney/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <Button variant="contained" className={classes.button}>Agregar categoria</Button>
                        </div>
                    </form>
            </div>
        </>
    )
}

export default CreateCategory