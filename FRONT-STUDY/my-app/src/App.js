import logo from './aa.jpg';
import './App.css';
import React,{useState} from 'react';

function App() {

  const [itemNm, setItemNm] = useState('');
  const [price, setPrice] = useState('');

  const newItem = () => {
    console.log('new item');
    fetch('http://localhost:8080/api/item/new', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
    })
    .then(response => response.json())
    .then(data => {
      console.log('Success:', data);
      setItemNm(data.itemNm)
      setPrice(data.price)
    })
    .catch(error => {
      console.error('Error:', error);
    });
  }
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          리액트 수업
        </p>
        <button onClick={newItem}> AddItem</button>
        <p>
          itemNm = {itemNm}
          <br/>
          price = {price}
        </p>
        <a
          className="App-link"
          href="https://kauth.kakao.com/oauth/authorize?client_id=4474e35f252ce7879f907e8546382b80&redirect_uri=http://localhost:8080/oauth/kakao/callback&response_type=code"
          // target="_blank"
          rel="noopener noreferrer"
        >
          카카오 로그인
        </a>
      </header>
    </div>
  );
}

export default App;
