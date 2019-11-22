﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPrepProj.Classes
{
    using System.Collections;
    using System.Collections.Generic;
    using System;

    public class GraphAdjacencyList<K>
    {
        private List<List<K>> _vertexList = new List<List<K>>();
        private Dictionary<K, List<K>> _vertexDict = new Dictionary<K, List<K>>();

        public GraphAdjacencyList(K rootVertexKey)
        {
            AddVertex(rootVertexKey);
        }

        private List<K> AddVertex(K key)
        {
            List<K> vertex = new List<K>();
            _vertexList.Add(vertex);
            _vertexDict.Add(key, vertex);

            return vertex;
        }

        public void AddEdge(K startKey, K endKey)
        {
            List<K> startVertex = _vertexDict.ContainsKey(startKey) ? _vertexDict[startKey] : null;
            List<K> endVertex = _vertexDict.ContainsKey(endKey) ? _vertexDict[endKey] : null;

            if (startVertex == null)
                throw new ArgumentException("Cannot create edge from a non-existent start vertex.");

            if (endVertex == null)
                endVertex = AddVertex(endKey);

            startVertex.Add(endKey);
            endVertex.Add(startKey);
        }

        public void RemoveVertex(K key)
        {
            List<K> vertex = _vertexDict[key];

            //First remove the edges / adjacency entries
            int vertexNumAdjacent = vertex.Count;
            for (int i = 0; i < vertexNumAdjacent; i++)
            {
                K neighbourVertexKey = vertex[i];
                RemoveEdge(key, neighbourVertexKey);
            }

            //Lastly remove the vertex / adj. list
            _vertexList.Remove(vertex);
            _vertexDict.Remove(key);
        }

        public void RemoveEdge(K startKey, K endKey)
        {
            ((List<K>)_vertexDict[startKey]).Remove(endKey);
            ((List<K>)_vertexDict[endKey]).Remove(startKey);
        }

        public bool Contains(K key)
        {
            return _vertexDict.ContainsKey(key);
        }

        public int VertexDegree(K key)
        {
            return _vertexDict[key].Count;
        }

        public bool HasNeighbours(K key)
        {
            return _vertexDict.ContainsKey(key);
        }

        public List<K> GetAllNeighbours(K key)
        {
            if (HasNeighbours(key))
                return _vertexDict[key];
            return null;
        }
    }

}
