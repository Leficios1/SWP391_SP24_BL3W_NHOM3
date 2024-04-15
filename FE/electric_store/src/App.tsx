import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Header from './shared/layout/header/header';
import Footer from './shared/layout/footer';
import Home from './modules/home/home';
import AppRoutes from './routers/routes';


function App() {
  return (
    <>
      <BrowserRouter>
        <Header />
        <div className='app-container'>
          <AppRoutes />
        </div>
        <Footer />
      </BrowserRouter>
    </>
  );
}

export default App;
