import './Login.scss';
import axios from "axios";
import React, { useState } from "react"
import Cookies from 'js-cookie';
import { Navigate, useNavigate } from 'react-router-dom';


const Login = ({setIsAuthenticated}) => {
  const [username, setUsername] = useState('admin@gmail.com');
  const [password, setPassword] = useState('12345');
  const navigate = useNavigate();

  const handleSubmit = async (event: React.FormEvent) =>
    {
      event.preventDefault;
      try {
        const response = await axios.post(
          'https://epplus.azurewebsites.net/api/Auth/login',
          {username, password},
          {withCredentials: true} 
        );
        if (response.status === 200) {
          const {data} = response;
          Cookies.set('token', data.token);          
          console.log('Login successfull');
          setIsAuthenticated(true);
          navigate('/');
        } else {console.log('Login failed!')}
        
      } catch (error) {
        console.error(error);
        
      }
    };

    return (
      <div className="login">
        <h1>Login page</h1>
          <form onSubmit={handleSubmit}>
            <label>
              Username:
              <input type="text" value={username} onChange={(e) => setUsername(e.target.value)} />
            </label>
            <label>
              Password:
              <input type="password" value={password} onChange={(e) => setPassword(e.target.value)}/>
            </label>
            <input type="submit" value="submit" />
          </form>
      </div>
    );
};

export default Login;