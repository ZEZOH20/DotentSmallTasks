import "./App.css";
import CustomForm from "./Components/CustomForm";
import ButtonDynamic from "./Components/Dynamic/ButtonDynamic/ButtonDynamic";
import PopUpWindow from "./Components/PopUpWindow/PopUpWindow";
import Table from "./Components/Table/Table";
import { Route, Routes, useNavigate } from "react-router-dom";
import FakeJsonData from "./Components/FakeJsonData.json"
function App() {
  console.log(FakeJsonData);
  return (
    <>
      {/* <PopUpWindow /> */}
      {/* <Table /> */}
      {/* <ButtonDynamic /> */}
    </>
  );
}

export default App;
