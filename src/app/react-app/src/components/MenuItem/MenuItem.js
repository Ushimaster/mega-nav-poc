import { useState } from "react";
import "./MenuItem.css";

const MenuItem = (props) => {
  
  const item = props.item;


  const clickHandler=()=>{
    props.onChangeMenu(item);
  };

  return (
    <li className="dropdown list">
      <a
        className="dropdown-toggle list__item"
        href="#"
        data-toggle="collapse"
        data-target="#navbarToggleExternalContent"
        aria-haspopup="true"
        onClick={clickHandler}
      >
        {item.title}
      </a>
    </li>
  );
};

export default MenuItem;
