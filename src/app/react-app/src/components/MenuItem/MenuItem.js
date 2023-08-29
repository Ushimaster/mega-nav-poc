import "./MenuItem.css";

const MenuItem = (props) => {
  
  const item = props.item;


  const clickHandler=()=>{
    props.onChangeMenu(item);
  };

  return (
    <li className="dropdown menu-item">
      <a
        className="dropdown-toggle menu-item__item"
        href={item.link}
        data-toggle="collapse"
        data-target="#navbarToggleMeganav"
        aria-haspopup="true"
        onClick={clickHandler}
      >
        {item.title}
      </a>
    </li>
  );
};

export default MenuItem;
