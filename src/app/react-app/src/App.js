import React from "react";
import "./App.css";
import { MenuProvider } from "./context/MenuProvider";
import HorizontalMeganav from "./features/HorizontalMeganav/HorizontalMeganav";

class App extends React.Component {
  
  render() {
    return (
      <MenuProvider>
        <HorizontalMeganav />
      </MenuProvider>
    );
  }
}

export default App;
