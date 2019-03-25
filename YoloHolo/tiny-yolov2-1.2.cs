using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Media;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.AI.MachineLearning;
namespace YoloHolo
{
    
    public sealed class Input
    {
        public TensorFloat image; // shape(-1,3,416,416)
    }
    
    public sealed class Output
    {
        public TensorFloat grid; // shape(-1,125,13,13)
    }
    
    public sealed class Model
    {
        private LearningModel model;
        private LearningModelSession session;
        private LearningModelBinding binding;
        public static async Task<Model> CreateFromStreamAsync(IRandomAccessStreamReference stream)
        {
            Model learningModel = new Model();
            learningModel.model = await LearningModel.LoadFromStreamAsync(stream);
            learningModel.session = new LearningModelSession(learningModel.model);
            learningModel.binding = new LearningModelBinding(learningModel.session);
            return learningModel;
        }
        public async Task<Output> EvaluateAsync(Input input)
        {
            binding.Bind("image", input.image);
            var result = await session.EvaluateAsync(binding, "0");
            var output = new Output();
            output.grid = result.Outputs["grid"] as TensorFloat;
            return output;
        }
    }
}
