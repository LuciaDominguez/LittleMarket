import { Button } from '@material-ui/core';
import React from 'react';
import profile from './../resource/profile.png';
import './ListItem.css'

export const ListItem=()=> {
    return (
        <>    
             <div class="card">
              <img src={profile} alt="Denim Jeans" style={{ width:"100px", height:"100px"}}/>
               <h1>Tailored Jeans</h1>
                <p class="priceItem">$19.99</p>
                <p className=".limit">Some text about the jeans. Super slim and comfy lorem ipsum lorem jeansum. Lorem jeamsun denim lorem jeansum.</p>
                <p><Button>Ver</Button></p>
            </div>
        </>
    )
}

export default ListItem
