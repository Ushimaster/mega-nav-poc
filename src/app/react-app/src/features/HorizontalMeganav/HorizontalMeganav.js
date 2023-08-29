import "./HorizontalMeganav.css";
import Meganav from "../../components/Meganav/Meganav";
import React from "react";
import { MenuContext } from "../../context/MenuProvider";

class HorizontalMeganav extends React.Component {
  static contextType = MenuContext;

  constructor() {
    super();
    this.state = {
      menuItems: null,
    };
  }

  componentDidMount() {
    const {
      services: { menuService },
    } = this.context;

    let activeUser = document.getElementById("activeUserId");
    let userId = 0;

    if (activeUser) userId = activeUser.value;

    console.log("activeUserId", userId);
    menuService.get(userId).then((data) => {
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

export default HorizontalMeganav;
