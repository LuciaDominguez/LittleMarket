import React from 'react';
import {makeStyles,Card,CardActionArea,CardActions,CardContent,CardMedia,Button, Typography} from '@material-ui/core';
import './Cards.css'

const useStyles = makeStyles({
    root: {
      maxWidth: 450,
      minWidth: 350
    },
    media: {
      height: 140,
    },
  });

export const Cards=()=> {
    const classes = useStyles();

    return (
        <>
            <Card className={classes.root}>
              <CardActionArea>
                <CardMedia
                  className={classes.media}
                  image="/static/images/cards/contemplative-reptile.jpg"
                  title="Contemplative Reptile"
                />
                <CardContent>
                  <Typography gutterBottom variant="h5" component="h2">
                    Nombre del producto
                  </Typography>
                  <Typography variant="body2" color="textSecondary" className="cardText" component="p">
                    Lizards are a widespread group of squamate reptiles, with over 6,000 species, ranging
                    across all continents except Antarctica
                  </Typography>
                </CardContent>
              </CardActionArea>
              <CardActions>
                <Button size="small" color="primary" href="/product/product_id=0">
                  Ver
                </Button>
              </CardActions>
            </Card>
        </>
    )
}

export default Cards
