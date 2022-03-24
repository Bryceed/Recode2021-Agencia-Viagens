import React from 'react';
import {  Link  }  from 'react-router-dom';

import './Footer.css';

export default () => {
    return (
        <>
             <footer class="text-center footer1">
                <h1 class="text-center footer2"><strong>Traveller</strong> Co.</h1>
                <h5 class="text-center"><strong>Uma empresa</strong> que não existe<br/><br/></h5>

                <div class="btn-group" role="group">
                    <a class="btn btn-light" role="button" href="https://github.com/Bryceed" target="_blank"><i class="fab fa-github"></i>&nbsp; <strong>GitHub</strong></a><a class="btn btn-info" role="button" target="_blank" href="https://linkedin.com/in/wellington-do-nascimento"><i class="fab fa-linkedin"></i>&nbsp; LinkedIn</a>
                </div>
            </footer>
        </>
    )
}