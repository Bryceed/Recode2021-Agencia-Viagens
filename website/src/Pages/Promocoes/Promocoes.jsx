import React from 'react';

import Header from '../../Components/Header/Header';
import Footer from '../../Components/Footer/Footer';

import './Promocoes.css';

export default () => {
    return (
        <>
            <Header page="promo"></Header>
            <div class="text-center promo1">
                <div class="container promo2">
                    <h1 class="text-white"><strong>Promoções</strong></h1>
                    <p class="text-white-50">Economia e vantagens em um único lugar</p>
                </div>
            </div>
            <div class="container promo3">
                <div class="row">
                    <div class="col">
                        <div class="table-responsive">
                            <table class="table table-striped">
                                <caption class="text-end">
                                    <span class="badge rounded-pill bg-success">2</span>
                                </caption>
                                <thead>
                                    <tr>
                                        <th>
                                            <strong>Destino</strong>
                                        </th>
                                        <th class="text-center">
                                            <strong>Preço (R$)</strong>
                                        </th>
                                        <th class="text-center">
                                            <strong>Quantidade</strong>
                                        </th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Cell 1</td>
                                        <td class="text-center">
                                            <span class="badge bg-secondary">
                                                <span class="promo4">729,90</span>
                                            </span>
                                            <strong>530,42</strong>
                                        </td>
                                        <td class="text-center">1</td>
                                        <td class="text-end">
                                            <button class="btn btn-info btn-sm" type="button">Comprar</button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Cell 3</td>
                                        <td class="text-center">1</td>
                                        <td class="text-center">1</td>
                                        <td class="text-end">
                                            <button class="btn btn-info btn-sm" type="button">Comprar</button>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <Footer></Footer>
        </>
    )
}
