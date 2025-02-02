import React from 'react';
import Logo from './components/logo';
import Header from './components/header';
import Body from './components/body';

const App: React.FC = () => {
  return (
    <div className="App">
      <Header />
      <Body />
    </div>
  );
};

export default App;

