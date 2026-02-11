import { useRef } from "react";

export default function FocusInput() {
  const inputRef = useRef(null);

  const handleFocus = () => {
    inputRef.current.focus();
  };

  return (
    <div>
      <h2>Focus Input</h2>

      <input ref={inputRef} type="text" placeholder="Type here..." />

      <button onClick={handleFocus}>
        Focus Input
      </button>
    </div>
  );
}
