from llama_index.core import VectorStoreIndex, SimpleDirectoryReader, Settings
from llama_index.llms.openai import OpenAI
from llama_index.llms.ollama import Ollama
import os
from llama_index.embeddings.ollama import OllamaEmbedding

from dotenv import load_dotenv
load_dotenv()

Settings.llm = Ollama(model = os.getenv('MODEL'))
Settings.embed_model = OllamaEmbedding(model_name = os.getenv('MODEL'))

documents = SimpleDirectoryReader("./documents").load_data()
# Save the index for future use
index = VectorStoreIndex.from_documents(documents, show_progress=True)
index.storage_context.persist(persist_dir = f"./{os.getenv('MODEL')}")
