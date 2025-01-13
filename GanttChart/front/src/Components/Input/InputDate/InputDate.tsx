import React from "react";
import "../Input.css";
import "./InputDate.css";
const InputDate = ({ title }: { title: string }) => {
  return (
    <div>
      <label className="inputLabel">
        {title}
      </label>
      <input
        className="input"
        type="date"
        id={title}
        name={title}
        maxLength={40}
      />
    </div>
  );
};

export default InputDate;
