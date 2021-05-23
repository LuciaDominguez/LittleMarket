import { Avatar } from '@material-ui/core'
import React from 'react'
import './Comment.css'

export const Comment=()=> {
    return (
        <>
         <div className="commentStyle">
             <div className="headComment" ><Avatar style={{background:'#32f444'}}>LM</Avatar></div>
             <div className="headComment"><p id="usuario-pic" className="nameComment">Usuario</p></div>
             <p id="fecha">12/12/1999</p>
             <p id="comentario" className="comment">Aqui va el texto del comentario</p>
         </div>   
        </>
    )
}

export default Comment
