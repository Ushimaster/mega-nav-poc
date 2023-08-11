import "./App.css";
import Meganav from "./components/Meganav/Meganav";

const App = () => {
  const menuItems = [
    {
      id: 1,
      parent: null,
      title: "My Learning",
      link: "#",
    },
    {
      id: 2,
      parent: null,
      title: "Live Sessions",
      link: "#",
    },
    {
      id: 3,
      parent: null,
      title: "Achievements",
      link: "#",
    },
    {
      id: 4,
      parent: null,
      title: "Inbox",
      link: "#",
    },
    {
      id: 5,
      parent: null,
      title: "Others",
      link: "#",
    },
    {
      id: 100,
      parent: 1,
      title: "Global library",
      link: "#",
    },
    {
      id: 200,
      parent: 100,
      title: "Courses",
      link: "#",
    },
    {
      id: 201,
      parent: 100,
      title: "Learning Paths",
      link: "#",
    },
    {
      id: 202,
      parent: 100,
      title: "Brands",
      link: "#",
    }
  ];
  
  return <Meganav menuItems={menuItems} />;
};

export default App;
