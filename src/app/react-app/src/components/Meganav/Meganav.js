import "./Meganav.css";
import Toggle from "../Toggle/Toggle";
import MenuItem from "../Menu/Menu";
import { useState } from "react";

const Meganav = (props) => {
  //Hooks
  const [togglesFiltered, setToggle] = useState();

  //Variables
  const menuItems = props.menuItems.filter((item) => !item.parent);

  const menuChangeHandler = (menu) => {
    const toggles = props.menuItems.filter((item) => item.parent===menu.id);
    setToggle(toggles);
  };

  return (
    <div className="meganav">
      <nav className="navbar navbar-default navbar-inverse meganav__navbar">
        <MenuItem menuItems={menuItems} onChangeMenu={menuChangeHandler} />
      </nav>
      <div className="collapse" id="navbarToggleExternalContent">
        <div className="panel panel-default">
          <div className="panel-body">
            <Toggle toggles={togglesFiltered} menuItems={props.menuItems}/>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Meganav;
