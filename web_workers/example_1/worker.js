function current_timestamp() {
  return Date.now();
}

self.onmessage = (event) => {
  if (event.data.question === 'What time is it?'){
    self.postMessage({response: current_timestamp()});
  }
}
