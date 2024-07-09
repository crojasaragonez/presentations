import os
from llama_index.core import StorageContext, load_index_from_storage, Settings
from llama_index.llms.openai import OpenAI
from llama_index.llms.ollama import Ollama
from llama_index.embeddings.ollama import OllamaEmbedding
from dotenv import load_dotenv
load_dotenv()

# Settings.llm = Ollama(model = os.getenv('MODEL'), request_timeout=120.0)
# Settings.embed_model = OllamaEmbedding(model_name = os.getenv('MODEL'))

storage_context = StorageContext.from_defaults(persist_dir = f"./{os.getenv('MODEL')}")
index = load_index_from_storage(storage_context)

query_engine = index.as_query_engine()

while True:
    question = input("Digíte la pregunta (or type 'exit' to quit): ")
    if question.lower() == 'exit':
        break
    response = query_engine.query(question)
    print(f"Respuesta: {response}")

