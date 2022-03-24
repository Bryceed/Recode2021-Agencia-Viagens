import React from 'react';
import {  Link  }  from 'react-router-dom';

import Header from '../../Components/Header/Header';
import Footer from '../../Components/Footer/Footer';

import './Destinos.css';

export default () => {
    return (
        <>
            <Header page="destinos"></Header>
            <div class="text-center destinos1" >
                <div class="container destinos2">
                    <h1 class="text-white"><strong>Destinos</strong></h1>
                    <p class="text-white-50">Encontre passagens com ótimo custo-benefício</p>
                </div>
            </div>
            <div class="container destinos3">
                <div class="row">
                    <div class="col-12 col-sm-10 col-md-6 col-lg-4 col-xl-3 offset-sm-1 offset-md-0">
                        <div class="card destino4">
                            <div class="card-body text-center">
                                <img class="rounded img-fluid destino5" src="https://by3301files.storage.live.com/y4m6YdNWgIov8cPJJOXIdNE9mSIXBV6paKmmgab8m_62qQHFqbd_Phk8yCefO_WXarvCUCTFjs0AXUogxpP4veYVpPeoWxf704V3le_l5Sjp9QAIsPmdvK0X1cGyiFkjS1xnCTnie-Pj8IfeIRu9C9YyF60M2MaliVL8R3rMWtCOWW7VGeEaUY5wBCSbqRZcu4J?width=1080&amp;height=1080&amp;cropmode=none" width="100%" loading="lazy" />
                                <h4 class="text-center"><strong>Lugar</strong></h4>
                                <h6 class="text-center text-text-muted card-subtitle mb-2"><strong>Estado</strong> (País)</h6>
                                <p class="destinos6">R$ 249,90</p>
                                <button class="btn btn-outline-primary" type="button"><strong>Comprar</strong></button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <Footer></Footer>
        </>
    )
}