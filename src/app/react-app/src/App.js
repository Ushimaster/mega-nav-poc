import React from "react";
import "./App.css";
import Meganav from "./components/Meganav/Meganav";

class App extends React.Component {
  constructor() {
    super();
    this.state = {
      menuItems: null,
    };
  }

  componentDidMount() {
    let id = document.getElementById("Id");
    console.log("id",id);
    fetch("https://localhost:7084/api/menu/admin/ao/learner/manager")
      .then((response) => response.json())
      .then((data) => {
        console.log(data);
        this.setState({
          menuItems: data,
        });
      });
  }

  render() {
    return <Meganav menuItems={this.state.menuItems} />;
  }
}

export default App;
