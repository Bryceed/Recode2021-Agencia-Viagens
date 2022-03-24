import React from 'react';
import {  Link  }  from 'react-router-dom';

import './GoldenCircle.css';

export default () => {
    return (
        <>
            <div class="card gc1">
            <div class="card-body">
                <h1><strong>Quem</strong> somos?</h1>
                <p>A Traveller Company é uma empresa jovem, que traz consigo uma nova experiência de compra de passagens e navegação online.</p>
            </div>
        </div>
        <div class="card gc1">
            <div class="card-body">
                <h1><strong>Como</strong> fazemos?</h1>
                <p>Através de acordos com empresas áreas, conseguimos ofertar um dos melhores preços do mercado, ao realizarmos a compra massiva de pacotes de viagens.<br/></p>
                <p>Além disso, nossa equipe monitora constantemente por pessoas que desejam vender as suas milhas, o que nos permite vender tanto pacotes com um preço atrativo, assim como viagens avulsas também.<br/></p>
                <p>Por apenas termos nossas operações online, conseguimos garantir um preço ainda menor, uma vez que não temos gastos com loja física e/ou funcionários presenciais.</p>
            </div>
        </div>
        <div class="card">
            <div class="card-body">
                <h1><strong>Por que</strong> nos escolher?</h1>
                <p>Somos uma empresa nacional que reconhece o perfil econômico geral dos brasileiros, onde nos destacamos como uma das melhores opções de custo-benefício, na compra de passagens aéreas pela internet.</p>
            </div>
        </div>
        </>
    )
}