import { React } from 'react';
import { Link } from 'react-router-dom';

import './Header.css';

export default () => {
    return (
        <>
            <div className="menu">
                <header>
                    <nav className="navbar navbar-light navbar-expand-lg fixed-top">
                        <div class="container-fluid">
                            <a class="navbar-brand" href="/" rel="noreferrer">
                                <strong>Traveller</strong> Co.
                            </a>
                            <button data-bs-toggle="collapse" class="navbar-toggler" data-bs-target="#navcol-1">
                                <span className="visually-hidden">Toggle navigation</span>
                                <span className="navbar-toggler-icon"></span>
                            </button>
                            <div className="collapse navbar-collapse" id="navcol-1">
                                <ul className="navbar-nav text-center mx-auto">
                                    <li className="nav-item">
                                        <Link className="nav-link active" to="/">Home</Link>
                                    </li>
                                    <li className="nav-item">
                                        <Link className="nav-link" to="/destinos">Destinos</Link>
                                    </li>
                                    <li className="nav-item">
                                        <Link className="nav-link" to="/promocoes">Promoções</Link>
                                    </li>
                                    <li className="nav-item">
                                        <Link className="nav-link" to="/contato">Contato</Link>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </nav>
                </header>
                <div className="menu-helper"></div>
            </div>
        </>
    )
}