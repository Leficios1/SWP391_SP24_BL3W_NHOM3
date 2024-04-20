import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import React, { useState, useEffect } from 'react';
import Cookies from 'js-cookie';
import Login from './pages/login/Login';
import Layout from './Layout';
import User from './pages/user/User';
import Staff from './pages/staff/Staff';
import Product from './pages/product/Product';
import Editable from './components/editableTable/Editable';

function App() {
  const [isAuthenticated, setIsAuthenticated] = useState(false);

  useEffect(() => {
    const token = Cookies.get('token');
    if (token) {
      setIsAuthenticated(true);
    }
  }, []);

  return (
    <Router>
      {isAuthenticated ? (
        <Routes>
          <Route path="/" element={<Layout />}>
            <Route path="/users/:id" element={<User />} />
            <Route path="/staff/:id" element={<Staff />} />
            <Route path="/products/:id" element={<Product />} />
            <Route path="/editable" element={<Editable />} />
          </Route>
        </Routes>
      ) : (
        <Route path="/login" element={<Login setIsAuthenticated={setIsAuthenticated} />} />
      )}
    </Router>
  );
}

export default App;