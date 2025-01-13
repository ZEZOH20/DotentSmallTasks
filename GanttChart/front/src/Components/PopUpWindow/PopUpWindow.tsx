import React, { useState } from "react";
import InputText from "../Input/InputText/InputText";
import InputDate from "../Input/InputDate/InputDate";

const PopUpWindow = () => {
  const [selectedButton, setButton] = useState(0);
  const items = ["General", "Custom Columns"];
  return (
    <>
      <div className=" w-3/4 rounded-lg absolute top-1/2 left-1/2 -translate-x-1/2 -translate-y-1/2 shadow-lg">
        {/* Nav Content */}
        <div className="bg-blue-500 h-22 rounded-t-lg p-4 pb-0">
          <h4 className="text-lg mb-4 text-white font-medium">New Task</h4>
          {/* Nav Links */}
          <div className=" flex justify-start">
            {items.map((item, index) => (
              <>
                <div
                  className={`${
                    selectedButton == index
                      ? `bg-white text-blue-950`
                      : `text-white`
                  } rounded-md rounded-b-none p-2 text-sm cursor-pointer mr-2`}
                  onClick={() => {
                    setButton(index);
                  }}
                >
                  {item}
                </div>
              </>
            ))}
          </div>
          {/* Nav Links */}
        </div>
        {/* Nav Content */}
        {/* Window body */}
        <div className=" grid grid-cols-1 sm:grid-cols-2 gap-3 p-6">
          <InputText title="Name"  />
          <InputText title="Name" />
          <InputText title="Name" />
          <InputText title="Name" />
          <InputDate title="FirstDate"/>
          <InputDate title="SecondDate"/>
        </div>
        {/* Window body */}
        <div className=" w-full flex justify-end p-5 b border-t">
          <button className=" mr-2 w-16 p-2 text-sm rounded-md bg-blue-500 text-white hover:bg-blue-600 hover:scale-95">Save</button>
          <button className=" w-16 p-2 text-sm  rounded-md text-blue-950 border border-blue-950 hover:bg-red-600 hover:border-red-600 hover:text-white hover:scale-95 transition-colors duration-200">Cancel</button>
        </div>
      </div>
    </>
  );
};

export default PopUpWindow;
