import React from "react";
import { FiSave } from "react-icons/fi";
import { IoMdClose } from "react-icons/io";

const TableHeader = () => {
  return (
    <>
      <div className="bg-gray-400">
        {/* Container */}
        <div className=" w-11/12 mx-auto">
          <div className=" flex justify-start">
            <div className=" w-40 flex justify-between ">
              <div className=" flex items-center">
                <div className=" mt-0.5">
                  <IoMdClose size={18} />
                </div>
                <div className=" ml-1">Update</div>
              </div>
              <div className=" flex items-center">
                <div className=" mt-0.5">
                  <FiSave size={18} />
                </div>
                <div className=" ml-1">Update</div>
              </div>
            </div>
          </div>
        </div>
        {/* Container */}
      </div>
    </>
  );
};

export default TableHeader;
