import { AttachMoney, FormatListNumbered, ShoppingBasket} from '@material-ui/icons'
import React from 'react'
import './CreateProduct.css'
import clsx from "clsx";
import { FormControl, InputLabel, Input, InputAdornment, TextField, Button,MenuItem, makeStyles } from '@material-ui/core';

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

const currencies = [
    {
      value: 'USD',
      label: '$',
    },
    {
      value: 'EUR',
      label: '€',
    },
    {
      value: 'BTC',
      label: '฿',
    },
    {
      value: 'JPY',
      label: '¥',
    },
  ];

export const CreateProduct=()=> {
    const [currency, setCurrency] = React.useState('EUR');
    const classes = useStyles();

      const handleChange = (event) => {
      setCurrency(event.target.value);
    };
    return (
        <>
             <div className="container">
                <h1 className="header">Crear producto</h1>
                    <form>
                    <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Nombre del producto</InputLabel>
                            <Input id="producto-nombre"
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
                            <InputLabel htmlFor="input-with-icon-adornment">Precio</InputLabel>
                            <Input id="producto-precio"
                            startAdornment={
                                <InputAdornment position="start">
                                    <AttachMoney/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                            <InputLabel htmlFor="input-with-icon-adornment">Descripcion</InputLabel>
                            <Input id="producto-descripcion"
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
                            <InputLabel htmlFor="input-with-icon-adornment">Cantidad</InputLabel>
                            <Input id="producto-precio"                     
                            startAdornment={
                                <InputAdornment position="start">
                                    <FormatListNumbered/>
                                </InputAdornment>
                            }>
                            </Input>
                        </FormControl>
                        </div>
                        <div className="box">
                        <FormControl className={clsx(classes.margin, classes.textField)}>
                             <TextField
                            id="producto-category"
                            select
                            label="Categoria"
                            value={currency}
                            onChange={handleChange}
                            helperText="Eliga una categoria"
                            >
                            {currencies.map((option) => (
                              <MenuItem key={option.value} value={option.value}>
                                {option.label}
                              </MenuItem>
                            ))}
                         </TextField>
                        </FormControl>
                        </div>
                        <div className="box">
                        <Button variant="contained" className={classes.button}>Agregar producto</Button>
                        </div>
                    </form>
            </div>
        </>
    )
}

export default CreateProduct
