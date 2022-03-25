import { React, useState, useRef } from 'react'
import {  Link  }  from 'react-router-dom';
import Axios from '../../Connection/axios'

import Header from '../../Components/Header/Header';
import Footer from '../../Components/Footer/Footer';

import './Contato.css';


const Contato = () => { 

    const name = useRef()
    const email = useRef()
    const phone = useRef()
    const contact_title = useRef()
    const contact_description = useRef()
    const contact_date = useRef()
    const isActive = useRef()
    
    const [Name, setName] = useState('')
    const [Email, setEmail] = useState('')
    const [Phone, setPhone] = useState('')
    const [Contact_title, setContact_title] = useState('')
    const [Contact_description, setContact_description] = useState('')
    const [Contact_date, setContact_date] = useState('')
    const [IsActive, setIsActive] = useState('')

    function send(event){
        event.preventDefault()
        Axios.post("/tickets/create",{
            name: name.current.value,
            email: email.current.value,
            phone: phone.current.value,
            contact_title: contact_title.current.value,
            contact_description: contact_description.current.value,
            contact_date: contact_date.current.value,
            isActive: 1
        }).then((res)=>console.log(res.data)).catch((err)=>console.log(err))
    }

    return (
        <>  
            <Header></Header>
            <div className="text-center contato1">
                <div className="container contato2">
                    <h1 className="text-white">
                        <strong>Contate-nos</strong>
                    </h1>
                    <p className="text-white-50">Precisando de ajuda? Não hesite em nos comunicar</p>
                </div>
            </div>
            <div className="container contato3">
                <div className="row">
                    <div className="col">
                        <h1>
                            <strong>Formulário</strong><br/><br/>
                        </h1>
                        <form onSubmit={send}>
                            <label className="form-label">Nome</label>
                            <input type="text" className="form-control" ref={name} placeholder="Ex.: Wellington do Nascimento" value={Name} onChange={e => setName(e.target.value)}/>
                            <label className="form-label">Email</label>
                            <input type="email" className="form-control" ref={email} placeholder="Ex.: Wellington.Nascimento@recode.org.br" value={Email} onChange={e => setEmail(e.target.value)}/><br/>
                            <label className="form-label">Telefone</label>
                            <input type="text" className="form-control" ref={phone} placeholder="Ex.: (11) 94201-8873" value={Phone} onChange={e => setPhone(e.target.value)}/>
                            <label className="form-label">Motivo do contato</label>
                            <input type="text" className="form-control" ref={contact_title} placeholder="Ex.: Não consigo acessar a minha conta" inputmode="latin" value={Contact_title} onChange={e => setContact_title(e.target.value)}/>
                            <label className="form-label">Detalhamento</label>
                            <textarea className="form-control" ref={contact_description} inputmode="latin" value={Contact_description} placeholder="&quot;Estou tentando redefinir a senha, mas o e-mail ainda não chegou. Por favor, poderiam me ajudar?&quot;" onChange={e => setContact_description(e.target.value)}></textarea><br/>
                            <label className="form-label">Data <small>(informe a data do início do problema)</small></label>
                            <input type="date" className="form-control" ref={contact_date} value={Contact_date} onChange={e => setContact_date(e.target.value)}/>
                            <p>
                                <div className="alert alert-warning" role="alert">
                                    <label>Ao enviar esse formulário, você automaticamente consente e concorda com os <strong>Termos de Uso e Processamento de Dados</strong> da Traveller Co. e de seus parceiros.</label>
                                </div>
                            </p>
                            <br/>
                            <button className="btn btn-success btn-lg"  onChange={e => alert(e.target.value)}>Enviar</button>
                        </form>
                    </div>
                </div>
            </div>
            <Footer></Footer>
        </>
    )
}

export default Contato;