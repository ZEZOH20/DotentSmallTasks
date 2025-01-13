import { useState } from "react";
import "../Input.css";
import "./InputText.css";

type InputTextType = {
  [key: string]: string; // All props content types is string
};

const InputText = ({ title, style }: InputTextType) => {
  const [content, setContent] = useState<string | undefined>(); // " "
  return (
    <>
      <div>
        <label className=" inputLabel ">{title}</label>
        <input
          className={style ? style : `input`}
          type="text"
          id={title}
          name={title}
          maxLength={40}
          placeholder="New Task"
          value={content}
          onChange={(e) => {
            setContent(e.target.value);
          }}
        />
      </div>
    </>
  );
};

export default InputText;
