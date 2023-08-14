import "./Meganav.css";
import Toggle from "../Toggle/Toggle";
import MenuItem from "../Menu/Menu";
import { useState } from "react";

const Meganav = (props) => {
  //Hooks
  const [togglesFiltered, setToggle] = useState();

  //Variables
  let menuItemsParent;

  if (props.menuItems)
    menuItemsParent = props.menuItems.filter((item) => item.parentId===0);

  const menuChangeHandler = (menu) => {
    const toggles = props.menuItems.filter((item) => item.parentId === menu.id);
    setToggle(toggles);
  };

  return (
    <div className="meganav">
      {menuItemsParent && (
        <>
          <nav className="navbar navbar-default navbar-inverse meganav__navbar">
            <MenuItem
              menuItems={menuItemsParent}
              onChangeMenu={menuChangeHandler}
            />
          </nav>
          <div className="collapse" id="navbarToggleExternalContent">
            <div className="panel panel-default">
              <div className="panel-body">
                <Toggle toggles={togglesFiltered} menuItems={props.menuItems} />
              </div>
            </div>
          </div>
        </>
      )}      
    </div>
  );
};

export default Meganav;
