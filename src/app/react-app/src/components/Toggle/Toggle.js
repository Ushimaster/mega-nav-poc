import "./Toggle.css";
import ToggleItem from "../ToggleItem/ToggleItem";
import { useState } from "react";

const Toggle = (props) => {
  const toggles = props.toggles;

  return (
    <div className="row">
      {(!toggles || toggles.length === 0) && (
        <div className="col-sm-12">
          <h5>No options found</h5>
        </div>
      )}
      {toggles &&
        toggles.length > 0 &&
        toggles.map((toggle) => {
          return (
            <div
              key={toggle.id}
              className="col-sm-12 col-sm-6 col-md-3 col-lg-2"
            >
              <ToggleItem toggle={toggle} menuItems={props.menuItems} />
            </div>
          );
        })}
    </div>
  );
};

export default Toggle;
