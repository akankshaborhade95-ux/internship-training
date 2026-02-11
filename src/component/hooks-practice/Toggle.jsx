import { useState } from "react";

export default function Toggle() {
  const [show, setShow] = useState(true);
  return (
    <div className="component">
      <button onClick={() => setShow(!show)}>
        {show ? "Hide" : "Show"}
      </button>
      {show && <p> Stay consistent and never give up. Every small step you take today
          builds your future.Practice daily, learn from mistakes,and keep
          improving your skills.Success comes to those who work hard and stay
          patient. You can achieve anything with dedication</p>}
    </div>
  );
}