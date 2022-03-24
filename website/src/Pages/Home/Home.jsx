import React from 'react';
import {  Link  }  from 'react-router-dom';

import Header from '../../Components/Header/Header';
import GC from './Content/GoldenCircle';
import Footer from '../../Components/Footer/Footer';

import './Home.css';

export default () => {
    return (
        <>
            <Header page="home"></Header>
            <div class="d-flex d-xl-flex flex-column justify-content-end align-items-center justify-content-xl-end align-items-xl-center home1" >
                <div class="image-background home2" ></div>
                <h1 class="text-center text-white home3"><strong>Boas-vindas!</strong></h1>
                <p class="text-muted">Sua próxima viagem começa aqui</p>
            </div>
            <h1 class="text-center home4"><i class="material-icons home5" >keyboard_arrow_down</i></h1>
            <div class="container" style={{marginTop:"48px"}}>
                <GC></GC>
            </div>
            <Footer></Footer>
        </>
    )
}