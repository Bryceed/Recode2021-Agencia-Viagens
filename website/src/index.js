import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Router, Route, Routes} from 'react-router-dom';

import './index.css';
import PageIndex from './Pages/Home/Home';
import PageDestinos from './Pages/Destinos/Destinos';
import PagePromocoes from './Pages/Promocoes/Promocoes';
import PageContato from './Pages/Contato/Contato';

ReactDOM.render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<PageIndex/>} />
        <Route path="/destinos" element={<PageDestinos/>} />
        <Route path="/promocoes" element={<PagePromocoes/>} />
        <Route path="/contato" element={<PageContato/>} />
      </Routes>
    </BrowserRouter>
  </React.StrictMode>,
  document.getElementById('root')
);


