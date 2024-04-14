import ClassicEditor from "@ckeditor/ckeditor5-build-classic"
import { CKEditor } from "@ckeditor/ckeditor5-react"
import React, { useRef } from "react"
import { useParams } from "react-router-dom"
const ProductDetail: React.FC = () => {

    const { id } = useParams()
    const editorRef = useRef<any>();

    // ClassicEditor
    //     .create(editorRef.current!)
    //     .then(editor => {
    //         // Lắng nghe sự kiện change và lấy dữ liệu
    //         editor.model.document.on('change:data', () => {
    //             const data = editor.getData();
    //             console.log("dataaaaaaaa", data); // In dữ liệu từ CKEditor
    //         });
    //     })
    //     .catch(error => {
    //         console.error(error);
    //     });

    return (
        <CKEditor
            ref={editorRef}
            editor={ClassicEditor}
            data="<p>Hello from CKEditor&nbsp;5!</p>"
            onReady={editor => {
                // You can store the "editor" and use when it is needed.
                console.log('Editor is ready to use!', editor);
            }}
            onChange={(event: any) => {
                console.log("Event source: ", event.source);
            }}
            onBlur={(event, editor) => {
                console.log('Blur.', editor);
            }}
            onFocus={(event, editor) => {
                console.log('Focus.', editor);
            }}


        />
    )
}


export default ProductDetail