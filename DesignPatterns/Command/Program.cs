using Command;
using Command.Commands;

var fs = FileSystemReceiverUtils.GetFileSystemReceiver();

var openFileCommand = new OpenFileCommand(fs);
var invoker = new FileInvoker(openFileCommand);
invoker.Execute(); 

var writeFileCommand = new WriteFileCommand(fs);
invoker = new FileInvoker(writeFileCommand);
invoker.Execute(); 

var closeFileCommand = new CloseFileCommand(fs);
invoker = new FileInvoker(closeFileCommand);
invoker.Execute(); 