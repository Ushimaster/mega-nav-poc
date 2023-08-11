import "./Toggle.css";
import ToggleItem from "../ToggleItem/ToggleItem";
import { useState } from "react";

const Toggle = (props) => {
  const toggles = props.toggles;

  return (
    <div className="row">
      <div className="col-sm-6 col-md-3 col-lg-2">
        {(!toggles || toggles.length === 0) && <p>No options found</p>}
        {toggles &&
          toggles.length > 0 &&
          toggles.map((toggle) => {
            return <ToggleItem key={toggle.id} toggle={toggle} menuItems={props.menuItems} />;
          })}
      </div>
    </div>
  );
};

export default Toggle;
