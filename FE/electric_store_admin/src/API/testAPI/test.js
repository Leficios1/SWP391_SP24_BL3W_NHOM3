import React, { useState, useEffect } from 'react';
import axios from 'axios';

const UserTable = () => {
  const [userData, setUserData] = useState([]);

  useEffect(() => {
    // Gọi API để lấy dữ liệu khi component được render
    axios.get('http://your-api-endpoint.com/getAllUsers')
      .then(response => {
        setUserData(response.data); // Lưu dữ liệu vào state
      })
      .catch(error => {
        console.error('Error fetching data:', error);
      });
  }, []); // Chỉ gọi API một lần khi component mount

  return (
    <div>
      <h1>User List</h1>
      <table>
        <thead>
          <tr>
            <th>User ID</th>
            <th>Username</th>
          </tr>
        </thead>
        <tbody>
          {userData.map(user => (
            <tr key={user.userId}>
              <td>{user.userId}</td>
              <td>{user.username}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default UserTable;
