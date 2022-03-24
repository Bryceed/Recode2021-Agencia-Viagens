import React from 'react';
import {  Link  }  from 'react-router-dom';

import Header from '../../Components/Header/Header';
import Footer from '../../Components/Footer/Footer';

import './Contato.css';

export default () => {
    return (
        <>  
            <Header page="contato"></Header> 
            <div class="text-center contato1">
                <div class="container contato2">
                    <h1 class="text-white">
                        <strong>Contate-nos</strong>
                    </h1>
                    <p class="text-white-50">Precisando de ajuda? Não hesite em nos comunicar</p>
                </div>
            </div>
            <div class="container contato3">
                <div class="row">
                    <div class="col">
                        <h1>
                            <strong>Formulário</strong>
                        </h1>
                        <form>
                            <label class="form-label">Nome</label>
                            <input class="form-control" type="text" placeholder="Ex.: Wellington do Nascimento" required="" />
                            <label class="form-label">E-mail</label>
                            <input class="form-control" type="text" placeholder="Ex.: Wellington.Nascimento@recode.org.br" required="" />
                            <label class="form-label">Telefone</label>
                            <input class="form-control" type="text" inputmode="tel" placeholder="Ex.: (11) 94201-8873" required="" />
                            <label class="form-label">Motivo do contato</label>
                            <input class="form-control" type="text" required="" placeholder="Ex.: Não consigo acessar a minha conta" inputmode="latin" />
                        </form>
                        <label class="form-label">Detalhamento</label>
                        <input type="text" class="form-control" required="" minlength="30" maxlength="1024" inputmode="latin" placeholder="&quot;Estou tentando redefinir a senha, mas o e-mail ainda não chegou. Por favor, poderiam me ajudar?&quot;" />
                        <p>
                            <input type="checkbox" required="" />
                            &nbsp;Concordo com os <strong>Termos de Uso e Processamento de Dados</strong> da Traveller Co. e seus parceiros.
                        </p>
                        <button class="btn btn-success btn-lg" type="button">
                            <strong>Enviar</strong>
                        </button>
                    </div>
                </div>
            </div>
            <Footer></Footer>
        </>
    )
}