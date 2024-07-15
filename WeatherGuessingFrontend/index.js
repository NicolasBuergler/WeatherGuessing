import React, { useState, useEffect } from 'react';
import ReactDOM from 'react-dom';
import './styles.css';

function App() {
    const [data, setData] = useState(null);
    const [result, setResult] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [currentStreak, setCurrentStreak] = useState(0);

    // Funktion zum Senden der Antwort
    const sendAnswer = async (answer) => {
        try {
            console.log(answer)
            const response = await fetch(`https://localhost:7118/QuizManager/solution?answer=${answer}&cityName=${data.city}`);
            if (response.ok) {
                const jsonData = await response.json();
                console.log(jsonData);
                setResult(jsonData); // Aktualisiere result mit der Antwort
                if (jsonData === true) {
                    setCurrentStreak(currentStreak + 1); // Inkrementiere den Highscore bei richtiger Antwort
                } else {
                    setCurrentStreak(0); // Setze den Highscore zurück bei falscher Antwort
                }
                fetchData();
            } else {
                setError('Error fetching solution');
            }
        } catch (error) {
            setError('Error fetching solution');
        }
    };

    const fetchData = async () => {
        try {
           const response = await fetch('https://localhost:7118/QuizManager');
           console.log(response);
          if (response.status === 200) {
            const jsonData = await response.json();
            setData(jsonData);
          } else {
            setError('Error fetching data');
          }
        } catch (error) {
          setError('Error fetching data');
        } finally {
          setLoading(false);
        }
      };
  
    useEffect(() => {
  
      fetchData();     
    }, []);

        // Effekt, der bei Änderungen von result ausgeführt wird
        useEffect(() => {
            console.log('Result updated:', result); // Hier kannst du etwas ausführen, wenn result sich ändert
        }, [result]);
  
    console.log(data?.city);

    if (loading) return <p>Loading...</p>;
    if (error) return <p>Error: {error}</p>;
  
    return (
        <div className="App">
          <h1>Errate die Temperatur von:</h1>
          <h2>{data?.city}</h2>
          <div className="options">
            <button onClick={() => sendAnswer(data?.tempratureOptions[0])}>{data?.tempratureOptions[0]}°C</button>
            <button onClick={() => sendAnswer(data?.tempratureOptions[1])}>{data?.tempratureOptions[1]}°C</button>
            <button onClick={() => sendAnswer(data?.tempratureOptions[2])}>{data?.tempratureOptions[2]}°C</button>
          </div>
          {result === false && <h3>Die Antwort war leider falsch</h3>}
          {result === true && <h3>Die Antwort war richtig</h3>}
          <p>Score: {currentStreak}</p>
        </div>
      );


  }

ReactDOM.render(<App />, document.getElementById('app'));