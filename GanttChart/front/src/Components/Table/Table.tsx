import React from "react";
import { ResponseData } from "../ResponseData";
import TableHeader from "./TableHeader/TableHeader";

 
const task = {
  TaskId: "Task No",
  tilte: "Title",
  startDate: "Start Date",
  endDate: "End Date",
  status: "Status",
};

const Table = () => {
  const data = JSON.parse(ResponseData);
  console.log(Object.keys(data["tasks"][0]));
  return (
    <>
      <div className=" w-10/12 mx-auto border border-gray-500 rounded-md">
        <TableHeader />
        <div>
          {/* container */}
          <div className=" w-11/12 mx-auto flex justify-between font-semibold">
            {Object.keys(data["tasks"][0]).map((key: string) => (
              <div>{task[key]}</div>
            ))}
          </div>
          {/* container */}
        </div>
      </div>
    </>
  );
};

export default Table;
