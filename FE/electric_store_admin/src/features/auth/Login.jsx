import { useEffect, useRef, useState } from "react";
import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";

import { useLoginMutation } from "./authApiSlice";
import { setCredentials } from "./authSlice";

const LoginForm = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const userRef = useRef();
    const errRef = useRef();
    const [error, setErrMsg] = useState('');
    const navigate = useNavigate()

    const [login, { isLoading }] = useLoginMutation()
    const dispatch = useDispatch()

    useEffect(() => {
        userRef.current.focus()

    }, [])

    useEffect(() => {
        setErrMsg

    }, [username, password])

    const handleSubmit = async (e) => {
            e.preventDefault();
            try {
                const userData = await login({ username, password }).unwrap()
                dispatch(setCredentials({...userData, user}))
                setUsername('')
                setPassword('')
                navigate('/')   
                const response = await axios.post('/login') 
              }catch (err) {
                if (!err?.response) {setErrMsg('No response');} 
                else if (err.response?.status === 400) {setErrMsg('Missing UsN or Pwd');} 
                else if (err.response?.status === 401) {setErrMsg('Unauthorized');}
                else {setErrMsg('login failed');}
                errRef.current.focus();           
            };
        }
    const handleUsernameInput = (e) => {
        setUsername(e.target.value)
    }
    const handlePasswordInput = (e) => {
        setPassword(e.target.value)
    }

    const content = isLoading ? <h1>Loading...</h1>:(
        <section>
            <p ref={errRef} className={errMsg ? "errmsg" : "offscreen"} aria-live="assertive">{errMsg}</p>
            <h1>Login</h1>
            <form onSubmit={handleSubmit}>
                <label htmlFor="username">Username</label>
                <input type="text" id="username" ref={userRef} value={username} onChange={handleUsernameInput} autoComplete="off" required />
                <label htmlFor="password">Password:</label>
                <input type="password" id="password" onChange={handlePwdInput} value={pwd} required/>
                <button>Sign In</button>
            </form>
        </section>
    )
    return content
}
export default LoginForm;







// import React, { useState } from 'react';
// import './Login.scss';
// import { FaUser, FaLock } from 'react-icons/fa';
// import axios from 'axios';
// import Cookies from 'js-cookie';
// import { Navigate, useNavigate } from 'react-router-dom';

// const token = localStorage.getItem('userToken');


// async function loginUser(credentials) {
//     return fetch("https://www.mecallapi.com/api/login", {
//       method: "POST",
//       headers: {
//         "Content-Type": "application/json",
//       },
//       body: JSON.stringify(credentials),
//     }).then((data) => data.json());
//   }

// const LoginForm = () => {
//   const [username, setUsername] = useState('');
//   const [password, setPassword] = useState('');
//   const navigate = useNavigate()
//   isAuthenticated: false

//   axios.defaults.baseURL = 'http://https://epplus.azurewebsites.net/api/';

//   const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
//     event.preventDefault();
//     try {
//       const response = await axios.post('/login', {
//         email: username,
//         password: password,
//       });
      
//       if(response.data.tokenString){
//         Cookies.set('token',response.data.tokenString);
//         axios.defaults.headers.common['Authorization'] = `Bearer ${token}`;
//         console.log('Login successful');
//         console.log(response.data.tokenString);
//         setisAuthenticated(true);
//         axios.defaults.withCredentials = true;
//         navigate('/');
//       }
//     } catch (error) {
//       console.error(error);
//     }

//     }


//   return (
//     <div className='wrapper'>
//       <form onSubmit={handleSubmit}>
//         <h1>Login</h1>
//         <div className="input-box">
//           <input type="text" placeholder="Username" required onChange={(e) => setUsername(e.target.value)}/>
//           <FaUser className='icon'/>
//         </div>
//         <div className="input-box">
//           <input type="password" placeholder="Password" required onChange={(e) => setPassword(e.target.value)}/>
//           <FaLock className='icon'/>
//         </div>

//         <button type="submit">Login</button>
//       </form>

//     </div>
//   );
// };

// export default LoginForm;

// import { Link } from 'react-router-dom';
// import { useForm } from "react-hook-form";
// import { yupResolver } from '@hookform/resolvers/yup';
// import * as Yup from 'yup';
// import { useDispatch } from 'react-redux';

// import { authActions } from '_store';

// export { Login };



// function Login() {
//     const dispatch = useDispatch();

//     // form validation rules 
//     const validationSchema = Yup.object().shape({
//         username: Yup.string().required('Username is required'),
//         password: Yup.string().required('Password is required')
//     });
//     const formOptions = { resolver: yupResolver(validationSchema) };

//     // get functions to build form with useForm() hook
//     const { register, handleSubmit, formState } = useForm(formOptions);
//     const { errors, isSubmitting } = formState;

//     function onSubmit({ username, password }) {
//         return dispatch(authActions.login({ username, password }));
//     }

//     return (
//         <div className="card m-3">
//             <h4 className="card-header">Login</h4>
//             <div className="card-body">
//                 <form onSubmit={handleSubmit(onSubmit)}>
//                     <div className="mb-3">
//                         <label className="form-label">Username</label>
//                         <input name="username" type="text" {...register('username')} className={`form-control ${errors.username ? 'is-invalid' : ''}`} />
//                         <div className="invalid-feedback">{errors.username?.message}</div>
//                     </div>
//                     <div className="mb-3">
//                         <label className="form-label">Password</label>
//                         <input name="password" type="password" {...register('password')} className={`form-control ${errors.password ? 'is-invalid' : ''}`} />
//                         <div className="invalid-feedback">{errors.password?.message}</div>
//                     </div>
//                     <button disabled={isSubmitting} className="btn btn-primary">
//                         {isSubmitting && <span className="spinner-border spinner-border-sm me-1"></span>}
//                         Login
//                     </button>
//                     <Link to="../register" className="btn btn-link">Register</Link>
//                 </form>
//             </div>
//         </div>
//     )
// }
